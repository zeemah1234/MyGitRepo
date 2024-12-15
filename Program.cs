using System;
public class RandomStringGenerator {
    public static void Main(String[] args) {
        int length = 10; // Length of the string
        char[] randomChars = new char[length]; // Array to store random characters
        
        Random random = new Random();
        
        for (int i = 0; i < length; i++) {
            // Generating a random character between 'a' and 'z'
            randomChars[i] = (char) (random.NextInt64(26) + 'a');
        }
        
        // Converting the char array to a String
        String randomString = new String(randomChars);
        
        // Printing the random string
       Console.WriteLine("Enter a string: " + randomString);
    }
}
