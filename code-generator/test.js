import * as R from 'ramda'

// const fl = 'restapi'
// const regexp = new RegExp(`/${fl}/(\\{[A-Za-z]+\\}|v[0-9.]+)`)

// let m = '/restapi/v1.0/account/{accountId}/meeting-recordings'.match(regexp)
// console.log(m[1])

// m = '/restapi/{restapiVersion}'.match(regexp)
// console.log(m[1])

// m = '/restapi/fdasfads'.match(regexp)
// console.log(m === null)

const prefix = '/scim/{version}/'
const name = 'Users'
const paramName = R.pipe(
  R.filter(p => p.startsWith(`${prefix}${name}/{`)),
  R.map(p => p.substring(`${prefix}${name}/`.length)),
  R.map(p => p.split('/').filter(t => t !== '')[0]),
  R.map(t => t.substring(1, t.length - 1)),
  R.head
)(['/scim/{version}/Users/{id}'])

console.log(paramName)
