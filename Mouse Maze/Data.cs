using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Mouse_Maze
{
    public static class Data
    {
        private const string stats = @"C:\Program Files\MouseMaze\MMStats.txt";
        private static bool[] complete = new bool[21];
        private static string[] time = new string[21];
        private static readonly string[] parTimes = { null, "040", "120", "400", "620", "300", "460", "600", "1000", "800", "260" };
        private static bool hardcore;
        private static bool hardcoreSelected;
        private static bool isLoaded;
        private const string initVector = "kdir93h58ydlr90c";
        private const int keysize = 256;
        private static string encryptedData = "";
        private static string decryptedData = "";
        private const string passKey = "jdk38d47fhj8dh3";



        public static void createStatsFile(string fileName)
        {
            File.Create(fileName).Dispose();
        }
        public static void Load_Data()
        {
            isLoaded = true;

            if (!File.Exists(stats))
            {
                createStatsFile(stats);
                Reset();
            }
            else
            {
                var read = new StreamReader(stats);
                decryptedData = Decrypt(read.ReadLine(), passKey);
                read.Close();
                using (var reader = new StringReader(decryptedData))
                {
                    for (var i = 1; i <= 20; i++)
                    {
                        if (reader.ReadLine() == "true")
                        {
                            complete[i] = true;
                        }
                        else
                        {
                            complete[i] = false;
                        }

                        time[i] = reader.ReadLine();
                    }

                    hardcore = reader.ReadLine() == "true";

                    hardcoreSelected = reader.ReadLine() == "true"; 
                }
            }

        }

        public static void WriteData()
        {
            var update = "";
            for (var i = 1; i <= 20; i++)
            {
                update += complete[i].ToString().ToLower() + "\r\n" + time[i] + "\r\n";

            }
            update += hardcore.ToString().ToLower() + "\r\n";
            update += hardcoreSelected.ToString().ToLower();
            encryptedData = Encrypt(update, passKey);
            File.WriteAllText(stats, encryptedData);
        }

        public static void LevelComplete(int l)
        {
            complete[l] = true;
        }

        public static void UpdateTime(int l, string t)
        {
            time[l] = t;
        }

        public static bool GetComplete(int c)
        {
            return complete[c];
        }

        public static string GetTime(int t)
        {
            return time[t];
        }

        public static bool GetHardcore()
        {
            hardcore = true;
            for (var i = 1; i <= 10; i++)
            {
                if (Convert.ToInt32(time[i]) > Convert.ToInt16(parTimes[i]))
                {
                    hardcore = false;
                }
            }
            return hardcore;
        }

        public static void SetHardcoreSelected()
        {
            hardcoreSelected = !hardcoreSelected;
        }

        public static bool GetHardcoreSelected()
        {
            return hardcoreSelected;
        }

        public static bool GetIsLoaded()
        {
            return isLoaded;
        }

        public static string GetParTimes(int i)
        {
            return parTimes[i];
        }

        public static void Reset()
        {
            isLoaded = false;
            var initial = "";
            for (var i = 1; i <= 20; i++)
            {
                complete[i] = false;
                time[i] = "99999";
                initial += "flase\r\n99999\r\n";
            }
            var temp = Encrypt(initial, passKey);
            File.WriteAllText(stats, temp);
        }

        private static string Encrypt(string plainText, string passPhrase)
        {
            byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            var password = new PasswordDeriveBytes(passPhrase, null);
            byte[] keyBytes = password.GetBytes(keysize / 8);
            var symmetricKey = new RijndaelManaged {Mode = CipherMode.CBC};
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
            var memoryStream = new MemoryStream();
            var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptoStream.FlushFinalBlock();
            var cipherTextBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            return Convert.ToBase64String(cipherTextBytes);

        }

        private static string Decrypt(string cipherText, string passPhrase)
        {
            var initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            var cipherTextBytes = Convert.FromBase64String(cipherText);
            var password = new PasswordDeriveBytes(passPhrase, null);
            var keyBytes = password.GetBytes(keysize / 8);
            var symmetricKey = new RijndaelManaged {Mode = CipherMode.CBC};
            var decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
            var ms = new MemoryStream(cipherTextBytes);
            var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read);
            var plainTextBytes = new byte[cipherTextBytes.Length];
            var decryptedByteCount = cs.Read(plainTextBytes, 0, plainTextBytes.Length);
            ms.Close();
            cs.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
        }
    }
}
