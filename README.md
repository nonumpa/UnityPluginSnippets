# Some code snippets for Unity plugins

## Test Runner 
Ref: https://hackmd.io/@jackchen/rkNRwuLmI

## JWT-DOTNET
- Decode without verify
- [WIP] Decode with verify (I didn't figure out how to load a publicKey in to jwt-dotnet)
  
  We should have a certificate first
  ```
   ssh-keygen -t rsa -b 4096 -m PEM -f jwtRS256.key
   ssh-keygen -e -m PEM -f jwtRS256.key > jwtRS256.key.pub
  ```