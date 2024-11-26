import java.util.Base64;

import javax.crypto.*;

public abstract class Document {
    protected String extension;
    protected String encryption;

    public static SecretKey generateKey() throws Exception {
        KeyGenerator keyGen = KeyGenerator.getInstance("AES");
        keyGen.init(256);
        return keyGen.generateKey();
    }

    public static String decrypt(String encryptedText, SecretKey key) throws Exception {
        Cipher cipher = Cipher.getInstance("AES");
        cipher.init(Cipher.DECRYPT_MODE, key);
        byte[] encryptedBytes = Base64.getDecoder().decode(encryptedText);
        byte[] decryptoBytes = cipher.doFinal(encryptedBytes);
        return new String(decryptoBytes);
    }

    public void setExtension(String extension) {
        this.extension = extension;
    }

    public void setEncryption(String encryption) {
        this.encryption = encryption;
    }

    public abstract Document buildDocument();
}
