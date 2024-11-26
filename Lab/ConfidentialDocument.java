import java.io.FileOutputStream;
import java.util.Base64;
import java.util.zip.ZipEntry;
import java.util.zip.ZipOutputStream;

import javax.crypto.Cipher;
import javax.crypto.SecretKey;

public class ConfidentialDocument extends Document {

    @Override
    public Document buildDocument() {
        this.setExtension("zip"); 
        this.setEncryption("AES"); 
        return this;
    }

    public void saveFile(String fileName, String content, SecretKey key) { 
        try { 
            // Encrypt the content 
            String encryptedContent = encrypt(content, key); 
            // Save the encrypted content to a .zip file 
            try (FileOutputStream fos = new FileOutputStream(fileName + "." + this.extension); 
            ZipOutputStream zos = new ZipOutputStream(fos)) { 
                ZipEntry zipEntry = new ZipEntry(fileName + ".txt"); 
                zos.putNextEntry(zipEntry); 
                zos.write(encryptedContent.getBytes()); 
                zos.closeEntry(); 
            } 
            System.out.println("Confidential document saved and encrypted successfully."); 
        } catch (Exception e) { 
            System.out.println("An error occurred while saving the confidential document."); 
            e.printStackTrace(); 
        }
    }
    public static String encrypt(String plainText, SecretKey key) throws Exception {
        Cipher cipher = Cipher.getInstance("AES");
        cipher.init(Cipher.ENCRYPT_MODE, key);
        byte[] cryptoBytes = cipher.doFinal(plainText.getBytes());
        return Base64.getEncoder().encodeToString(cryptoBytes);
    }
}
