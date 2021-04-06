import {parsed} from 'ringcentral-open-api-parser';
import fs from 'fs';
import path from 'path';

const outputDir = '../RingCentral.Net/Paths';

for (const item of parsed.paths) {
  console.log(item);
}
