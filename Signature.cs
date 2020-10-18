class Program
    {
        static void Main(string[] args)
        {
            string path = "/api/mobile/v3/user/login.json";
            string b = "9bde64a09e825d35a4128c813a05b5eff24b6ab6"; //android.support.v4.common.mp4.b()
            long ts = (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
            string plainString = path + b + ts;
            string hashedString = Hash(plainString);
            Console.WriteLine(plainString);
            Console.WriteLine("x-sig: " + hashedString);
            Console.WriteLine("x-ts: " + ts);
            Console.Read();
        }

        static string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
