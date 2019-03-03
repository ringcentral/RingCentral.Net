import * as R from 'ramda'

export const normalizePath = path => {
  return path
    .replace(/\/restapi\/v1\.0\//, '/restapi/{apiVersion}/')
    .replace(/\/scim\/v2/, '/scim/{version}')
    .replace(/\/\.search/, '/dotSearch')
}

export const deNormalizePath = path => {
  return path
    .replace(/\/restapi\/\{apiVersion\}\//, '/restapi/v1.0/')
    .replace(/\/scim\/\{version\}/, '/scim/v2')
    .replace(/\/dotSearch/, '/.search')
}

export const getResponseType = responses => {
  const responseSchema = (responses[200] || responses[201] || responses[202] || responses[204] || responses[205] || responses[302] || responses.default).schema
  let responseType
  if (responseSchema) {
    if (responseSchema.type === 'string' && responseSchema.format === 'binary') {
      responseType = 'byte[]'
    } else if (responseSchema['$ref']) {
      responseType = 'RingCentral.' + R.last(responseSchema['$ref'].split('/'))
    }
  }
  return responseType
}
