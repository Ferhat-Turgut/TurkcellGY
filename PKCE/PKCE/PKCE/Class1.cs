using System;
using System.Security.Cryptography;
using System.Text;

public class PKCEGenerator
{
    public static string GenerateCodeVerifier()
    {
        // Rastgele bir dize oluştur
        var randomBytes = new byte[32];
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(randomBytes);
        }

        // Dizeyi Base64 URL güvenli olarak kodla
        var codeVerifier = Base64UrlEncode(randomBytes);

        return codeVerifier;
    }

    public static string GenerateCodeChallenge(string codeVerifier)
    {
        // Code Verifier'ı SHA256 ile karma
        using (var sha256 = SHA256.Create())
        {
            var codeVerifierBytes = Encoding.ASCII.GetBytes(codeVerifier);
            var codeChallengeBytes = sha256.ComputeHash(codeVerifierBytes);

            // Code Challenge'ı Base64 URL güvenli olarak kodla
            var codeChallenge = Base64UrlEncode(codeChallengeBytes);

            return codeChallenge;
        }
    }

    private static string Base64UrlEncode(byte[] bytes)
    {
        var base64 = Convert.ToBase64String(bytes);
        var base64Url = base64.Replace('+', '-').Replace('/', '_').TrimEnd('=');

        return base64Url;
    }
}

public class Program
{
    public static void Main()
    {
        // Code Verifier ve Code Challenge oluşturma
        var codeVerifier = PKCEGenerator.GenerateCodeVerifier();
        var codeChallenge = PKCEGenerator.GenerateCodeChallenge(codeVerifier);

        Console.WriteLine("Code Verifier: " + codeVerifier);
        Console.WriteLine("Code Challenge: " + codeChallenge);
    }
}
