import {parsed} from 'ringcentral-open-api-parser';
import fs from 'fs';
import path from 'path';
import {pascalCase} from 'change-case';
import R from 'ramda';

const outputDir = '../RingCentral.Net/Paths';

for (const item of parsed.paths) {
  console.log(item);
  const itemPaths = item.paths.map(p => pascalCase(p));
  const parentPaths = R.init(itemPaths);
  const code = `
using System.Threading.Tasks;

namespace RingCentral.Paths.${itemPaths.join('.')}
{
    public partial class Index
    {
        public RestClient rc;
        public ${parentPaths.join('.')}.Index parent;
        ${item.parameter ? `public string ${item.parameter};` : ''}

        public Index(${parentPaths.join('.')}.Index parent${
    item.parameter ? `, string ${item.parameter} = null` : ''
  })
        {
            this.parent = parent;
            this.rc = parent.rc;
            ${
              item.parameter
                ? `this.${item.parameter} = ${item.parameter};`
                : ''
            }
        }

        ${
          item.parameter
            ? `public string Path(bool withParameter = true)
        {
            if (withParameter && ${item.parameter} != null)
            {
                return $"{parent.Path()}/${R.last(item.paths)}/{${
                item.parameter
              }}";
            }
            return $"{parent.Path()}/${R.last(item.paths)}";
        }`
            : `public string Path()
        {
            return $"{parent.Path()}/${R.last(item.paths)}";
        }`
        }
    }
}

namespace RingCentral.Paths.${parentPaths.join('.')}
{
    public partial class Index
    {
        public ${itemPaths.join('.')}.Index ${R.last(itemPaths)}(${
    item.parameter ? `string ${item.parameter} = null` : ''
  })
        {
            return new ${itemPaths.join('.')}.Index(this${
    item.parameter ? `, ${item.parameter}` : ''
  });
        }
    }
}
`.trim();
  const folder = path.join(outputDir, ...itemPaths);
  fs.mkdirSync(folder, {recursive: true});
  fs.writeFileSync(path.join(folder, 'Index.cs'), code);
}
