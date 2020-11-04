import hashlib, time

path = "/api/mobile/v3/user/login.json"
b = "9bde64a09e825d35a4128c813a05b5eff24b6ab6"
ts = str(round(time.time() * 1000))

plainString = path + b + ts
hashedString = hashlib.sha1(plainString.encode('utf-8')).hexdigest()

print("x-sig: " + hashedString)
print("x-ts: " + ts)
