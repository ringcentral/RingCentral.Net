import {parsed} from 'ringcentral-open-api-parser';
import fs from 'fs';
import path from 'path';
import {pascalCase, capitalCase} from 'change-case';
import R from 'ramda';
import {Operation} from 'ringcentral-open-api-parser/lib/types';

const outputDir = '../RingCentral.Net/Paths';

const generatePathMethod = (
  parameter: string | undefined,
  token: string
): string => {
  if (parameter) {
    return `public string Path(bool withParameter = true)
        {
            if (withParameter && ${parameter} != null)
            {
                return $"{parent.Path()}/${token}/{${parameter}}";
            }
            return $"{parent.Path()}/${token}";
        }`;
  } else {
    return `public string Path()
        {
            return $"{parent.Path()}/${token}";
        }`;
  }
};

const generateBridgeMethod = (
  parameter: string | undefined,
  itemPaths: string[]
): string => {
  return `namespace RingCentral.Paths.${R.init(itemPaths).join('.')}
{
    public partial class Index
    {
        public ${itemPaths.join('.')}.Index ${R.last(itemPaths)}(${
    parameter ? `string ${parameter} = null` : ''
  })
        {
            return new ${itemPaths.join('.')}.Index(this${
    parameter ? `, ${parameter}` : ''
  });
        }
    }
}`;
};

const generateConstructor = (
  parameter: string | undefined,
  parentPaths: string[]
): string => {
  return `public RestClient rc;
        public ${parentPaths.join('.')}.Index parent;
        ${parameter ? `public string ${parameter};` : ''}

        public Index(${parentPaths.join('.')}.Index parent${
    parameter ? `, string ${parameter} = null` : ''
  })
        {
            this.parent = parent;
            this.rc = parent.rc;
            ${parameter ? `this.${parameter} = ${parameter};` : ''}
        }`;
};

const generateOperationMethod = (operation: Operation): string => {
  const comments = ['/// <summary>'];
  comments.push(
    `${(
      operation.description ||
      operation.summary ||
      capitalCase(operation.operationId)
    )
      .split('\n')
      .map(l => `/// ${l}`)
      .join('\n')}`
  );
  comments.push(`/// HTTP Method: ${operation.method}`);
  comments.push(`/// Endpoint: ${operation.endpoint}`);
  if (operation.rateLimitGroup) {
    comments.push(`/// Rate Limit Group: ${operation.rateLimitGroup}`);
  }
  if (operation.appPermission) {
    comments.push(`/// App Permission: ${operation.appPermission}`);
  }
  if (operation.userPermission) {
    comments.push(`/// User Permission: ${operation.userPermission}`);
  }
  comments.push('/// </summary>');
  let result = comments.map(l => `        ${l}`).join('\n');
  let responseType = 'string';
  if (operation.responseSchema) {
    if (
      operation.responseSchema.type === 'string' &&
      operation.responseSchema.format === 'binary'
    ) {
      responseType = 'byte[]';
    } else if (operation.responseSchema.$ref) {
      responseType = `RingCentral.${R.last(
        operation.responseSchema.$ref.split('/')
      )}`;
    }
  }
  result += `
  public async Task<${responseType}> ${pascalCase(operation.method2)}()
  {

  }`;
  return result;
};

for (const item of parsed.paths) {
  const itemPaths = item.paths.map(p => pascalCase(p));
  const code = `
using System.Threading.Tasks;

namespace RingCentral.Paths.${itemPaths.join('.')}
{
    public partial class Index
    {
        ${generateConstructor(item.parameter, R.init(itemPaths))}
        ${generatePathMethod(item.parameter, R.last(item.paths)!)}
${item.operations
  .map(operation => generateOperationMethod(operation))
  .join('\n\n')}
    }
}

${generateBridgeMethod(item.parameter, itemPaths)}
`;
  const folder = path.join(outputDir, ...itemPaths);
  fs.mkdirSync(folder, {recursive: true});
  fs.writeFileSync(path.join(folder, 'Index.cs'), code.trim());
}
