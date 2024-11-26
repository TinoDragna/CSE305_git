import java.util.Base64;
import javax.crypto.Cipher;
import javax.crypto.KeyGenerator;
import javax.crypto.SecretKey;
import javax.crypto.spec.IvParameterSpec;

public class ConfidentialDoc extends Document {
    private static SecretKey generateKey;

    static {
        try {
            KeyGenerator keyGen = KeyGenerator.getInstance("AES");
            keyGen.init(256); // Using AES-256
            generateKey = keyGen.generateKey();
        } catch (Exception e) {
            throw new RuntimeException("Error generating AES key", e);
        }
    }

    @Override
    public Document setFileExtension(String extension) {
        this.extension = extension; // ".zip" extension
        return this;
    }

    @Override
    public Document setEncryption(String encryption) {
        // AES encryption required for ConfidentialDoc
        this.encryption = encryption;
        return this;
    }

    @Override
    public Document buildDoc() {
        System.out.println("Confidential document built with extension: " + this.extension +
                " and encryption: " + this.encryption);
        return this;
    }

    public String encrypt(String data) {
        try {
            Cipher cipher = Cipher.getInstance("AES/CBC/PKCS5Padding");
            IvParameterSpec iv = new IvParameterSpec(new byte[16]); // Using a zero IV for simplicity
            cipher.init(Cipher.ENCRYPT_MODE, generateKey, iv);
            byte[] encrypted = cipher.doFinal(data.getBytes());
            return Base64.getEncoder().encodeToString(encrypted);
        } catch (Exception e) {
            throw new RuntimeException("Error during encryption", e);
        }
    }

    // Method to decrypt text
    public String decrypt(String encryptedData) {
        try {
            Cipher cipher = Cipher.getInstance("AES/CBC/PKCS5Padding");
            IvParameterSpec iv = new IvParameterSpec(new byte[16]); // Using a zero IV for simplicity
            cipher.init(Cipher.DECRYPT_MODE, generateKey, iv);
            byte[] decoded = Base64.getDecoder().decode(encryptedData);
            byte[] decrypted = cipher.doFinal(decoded);
            return new String(decrypted);
        } catch (Exception e) {
            throw new RuntimeException("Error during decryption", e);
        }
    }

    // Getter for SecretKey (optional, for testing purposes)
    public static SecretKey getGenerateKey() {
        return generateKey;
    }
}