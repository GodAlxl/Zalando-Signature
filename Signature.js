const crypto = require("crypto");

let path = '/api/graphql/mobile';
let b = '9bde64a09e825d35a4128c813a05b5eff24b6ab6';
let ts = Date.now();

let plainString = path + b + ts;
let hashedString = sha1(plainString);

console.log(`x-sig: ${hashedString}`);
console.log(`x-ts: ${ts}`);

function sha1(data) {
    return crypto.createHash("sha1").update(data).digest("hex");
}
