import yaml from 'js-yaml'
import fs from 'fs'
import path from 'path'
import pascalCase from 'pascal-case'

const outputDir = '../RingCentral/Definitions/Generated'

const doc = yaml.safeLoad(fs.readFileSync('rc-platform-adjusted.yml', 'utf8'))
const definitions = doc.definitions
const models = Object.keys(definitions).map(k => ({ name: k, ...definitions[k] }))

const keys = []
models.forEach(m => {
  Object.keys(m).forEach(k => keys.push(k))
})

const types = []
models.forEach(m => {
  const properties = m.properties
  const fields = Object.keys(properties)
    .map(k => ({ name: k, ...properties[k] }))
    .map(f => {
      if (f.type === 'integer') {
        f.type = 'long?'
      } else if (f.type === 'array') {
        f.type = `${f.items.type || f.items['$ref'].split('/').slice(-1)[0]}[]`
      } else if (f.type === undefined || f.type === 'object') {
        f.type = f['$ref'].split('/').slice(-1)[0]
      } else if (f.type === 'boolean') {
        f.type = 'bool?'
      }
      if (['event', 'delegate', 'ref', 'default', 'operator', 'public'].includes(f.name)) {
        f.name = `@${f.name}`
      }
      types.push(f.type)
      return f
    })
  let source = `namespace RingCentral
{${m.description ? '\n    // ' + m.description : ''}
    public class ${m.name}
    {
        ${fields.map(f => {
    let p = ''
    if (f.name.includes('-')) {
      p += `[JsonProperty("${f.name}")]`
      p += `\n        public ${f.type} ${f.name.replace(/-([a-z])/g, (match, p1) => p1.toUpperCase())};`
    } else if (f.name.includes(':') || f.name.includes('.')) {
      p += `[JsonProperty("${f.name}")]`
      p += `\n        public ${f.type} ${f.name.replace(/[:.](\w)/g, '_$1')};`
    } else {
      p = `public ${f.type} ${f.name};`
    }
    if (m.required && m.required.includes(f.name)) {
      p += ` // Required`
    }
    if (f.enum) {
      p = `// Enum: ${f.enum.join(', ')}\n        ${p}`
    }
    if (f.description) {
      p = `// ${f.description.trim()}\n        ${p}`
    }
    return p
  }).join('\n\n        ')}
    }
}
`.trim()
  if (source.includes('[JsonProperty(')) {
    source = 'using Newtonsoft.Json;\n\n' + source
  }
  fs.writeFileSync(path.join(outputDir, `${m.name}.cs`), source)
})

// generate models for form-data objects
Object.keys(doc.paths).forEach(p => {
  Object.keys(doc.paths[p]).forEach(method => {
    const operation = doc.paths[p][method]
    if ((operation.parameters || []).some(p => p.in === 'formData')) {
      const operationId = operation.operationId
      const className = pascalCase(operationId) + 'Request'
      const fields = operation.parameters.filter(p => p.in === 'formData')
        .map(p => {
          let type = p.type
          const isArrayType = type === 'array'
          if (isArrayType) {
            type = p.items.type
          }
          if (type === 'integer') {
            type = 'long?'
          }
          if (type === 'file') {
            type = 'Attachment'
          }
          if (isArrayType) {
            type += '[]'
          }
          let f = `        public ${type} ${p.name};`
          if (p.description) {
            f = `        // ${p.description}\n${f}`
          }
          return f
        })
      const code = `namespace RingCentral
{
    public class ${className}
    {
${fields.join('\n\n')}
    }
}`
      fs.writeFileSync(path.join(outputDir, `${className}.cs`), code)
    }
  })
})

// Generate Attachment
fs.writeFileSync(path.join(outputDir, 'Attachment.cs'), `namespace RingCentral
{
    public class Attachment
    {
        // File name with extension, such as "example.png"
        public string fileName;

        // Binary content of the file
        public byte[] bytes;
    }
}`)
