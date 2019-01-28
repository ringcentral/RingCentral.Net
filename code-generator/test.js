
const fl = 'restapi'
const regexp = new RegExp(`/${fl}/(\\{[A-Za-z]+\\}|v[0-9.]+)`)

let m = '/restapi/v1.0/account/{accountId}/meeting-recordings'.match(regexp)
console.log(m[1])

m = '/restapi/{restapiVersion}'.match(regexp)
console.log(m[1])

m = '/restapi/fdasfads'.match(regexp)
console.log(m === null)
