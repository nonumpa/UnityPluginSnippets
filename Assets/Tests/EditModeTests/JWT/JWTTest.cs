// JWT generated from https://jwt.io/

using NUnit.Framework;
using UnityEngine;
using JWT;
using JWT.Serializers;

public class JWTTest
{
    // A Test behaves as an ordinary method
    [Test]
    [TestCase("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.cThIIoDvwdueQB468K5xDc5633seEFoqwxjF_xSJyQQ")]
    public void Decode(string jwtToken)
    {
        // ref: https://github.com/jwt-dotnet/jwt
        // If we don't have cert(public key) set verify to false
        // introduction to jwt: https://ithelp.ithome.com.tw/articles/10231212
        var decodedJsonString = new JwtDecoder(new JsonNetSerializer(), new JWT.JwtBase64UrlEncoder()).Decode(jwtToken, false);
        Debug.Log($"parsed token {decodedJsonString}");
    }

//     [Test]
//     [TestCase(
//         "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.f2j1Y-NNHzSgvknO4mDg3XH6ea2Fz7UXSaf_sCo7nJzezu3mvU29z8jrgUmnjgFsv2n_0tJONo28X5_wHKg5pmTg19-06bYp_EDVuD-h34JEO944ZiJFBq_NJnYS6a4bFd8Ha_0sMsVNwkmHKKslRgx2wo0SyepkOUbfaeXFwtPXbfajo3wQowS3K1beNjsiPf1N22JLZeT9g4FnQaS6UPUYHPjBHpOfS8kT5_BWKKObFmFxby5ARvPTmuhACKjHUBDaxi706g5-v9Pa5Z6lQSZOKfXw7yPSbktrJeuAk69LmS0R1ChqIj7UfHIu8rMvMi07jTMpHrR6GarMnj0baiqJIG7aY5yX6YKn_t4LApjXCAfdG5w1uw13abAj9Qptny-yiJeW8QK4exHDuFIe3-vfpmY3SewMCzAxcafNqNAd6Xk8sRX7BVfxAOPBz-BZXKzj288rvkenEK1HU8N3DTfZN6Bxx88Yiy1PZK93C4ppslLXgZ7YQG_gqqmoU6reKqomf8o_v2sCfraHJWgFmLrVyiamWnRxQXVPMUgkMU4cYLk3GGw5a6DZ_CqlUJc-OcVyolcdEcG_L2fHl3-mAfqf-ioTaV7yF89Azrqz2Bw_-CbXIF3ZQNWm4Yjhm78wjMPw-tW5UZiUJ8D6XIihChQnbJluA-3gJcSDrVNMQsg",
//         @"MIICCgKCAgEAoU+hpa6VGu+VeQfq4r/SRgSOaLyoqg3A8c1ynPXm0r84IsR4122p
// kiAuHgR3j/Ti9JHS8KcYTdBg+iz8VOfTFvJOQWdQ4kom8esZRwjTzJ5+fOxUZAd/
// V3GL95cjJ6iEtPP/FWShNAjP3NbgP9yvlL9XCxrTt3IhQx8v+4Egj/oK5d+EjYkZ
// kZl1J5kfpUlaKzK984wZUW6oHwGmUVOfh7flvZNWB9dl2BMNRnE3Iz14Qakw7IVY
// KFzcMxBaQ63k13h4mJD0zfmZXs8GDJvsr2kIs14GGOHHOHF8w8yUueCowoctvovw
// TXYzCq4+kJferaGv0+SbnwHMHd9Tydq9DaBypL6GAh/kA9bh+pM5aUdALzMl/DY/
// tKHxGXGtgvbAkzs2NHZCKeTt16JQnvW1KnA8xHlkn859QhNCs0wtDC1SuvuqR//0
// rWqGmYb3xyLykNH8bj495jdvot5FgSV2nKWJ+2ceRur2fOoaDe9WhwgiDblyHDdU
// 3Uixok3/mib76HAk+IbfglJHF7C6MQTfP0DqRJuClNUZTBqX8aXqouY2RzZ202w/
// hNEhZzneCb1EaUu/O9Q8UcBlbM37uLsJocrllcLoQC7cbyRCfOIFXrQwkKtU9soI
// yIlDVhJ4CKRUCmJ2fg2hwwtfI5iwz/gJ0yNfEVdFOls/R2+d/YyDLEUCAwEAAQ==")]
//     public void Decode(string jwtToken, string publicKey)
//     {
//         // read from path
//         // X509Certificate2 pubcrt = new X509Certificate2(txtPublicKeyPath.Text.Trim());
//         byte[] pubKeyBytes = Convert.FromBase64String(publicKey);
//         // RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
//         // rsa.im(pubKeyBytes);
//         RSACryptoServiceProvider rsaPublic = new RSACryptoServiceProvider();
//         rsaPublic.ImportRSAPublicKey(pubKeyBytes, out _);
//         X509Certificate2 x509 = new X509Certificate2(pubKeyBytes);
//         // x509.Import(pubKeyBytes);
//         // read from string
//         // X509Certificate2 pubcrt = new X509Certificate2(Convert.FromBase64String(publicKey), string.Empty, X509KeyStorageFlags.MachineKeySet);
//         // RSACryptoServiceProvider pubkey = (RSACryptoServiceProvider)pubcrt.PublicKey.Key;
//         byte[] keyByte = System.Text.UTF8Encoding.ASCII.GetBytes(publicKey);
//         // ref: https://github.com/jwt-dotnet/jwt
//         IJsonSerializer serializer = new JsonNetSerializer();
//         IDateTimeProvider provider = new UtcDateTimeProvider();
//         IJwtValidator validator = new JwtValidator(serializer, provider);
//         IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
//         IJwtAlgorithm algorithm = new RS256Algorithm(rsaPublic);
//         // var builder  = JwtBuilder.Create()
//         //                 .WithAlgorithm(new HMACSHA256Algorithm())
//         //                 .WithSecret(publicKey);    
//         IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder, algorithm);

//         var decodedJsonString = decoder.Decode(jwtToken);
//         Debug.Log($"parsed token {decodedJsonString}");
//     }
}
