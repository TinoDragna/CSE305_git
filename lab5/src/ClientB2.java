public class ClientB2 {
    public static void main(String[] args) {
        // Test NormalDoc
        System.out.println("Testing NormalDoc:");
        Document normalDoc = new NormalDoc();
        normalDoc.setFileExtension(".txt")
                 .setEncryption("None")
                 .buildDoc();
        System.out.println("Normal document created successfully.\n");

        // Test ConfidentialDoc with encryption and decryption
        System.out.println("Testing ConfidentialDoc:");
        ConfidentialDoc confidentialDoc = new ConfidentialDoc();
        confidentialDoc.setFileExtension(".zip")
                       .setEncryption("AES")
                       .buildDoc();

        // Encrypt and decrypt a sample message
        String secretMessage = "This is a confidential document content.";
        String encryptedMessage = confidentialDoc.encrypt(secretMessage);
        System.out.println("Encrypted Message: " + encryptedMessage);

        String decryptedMessage = confidentialDoc.decrypt(encryptedMessage);
        System.out.println("Decrypted Message: " + decryptedMessage);

        // Verify the content matches the original
        if (secretMessage.equals(decryptedMessage)) {
            System.out.println("Decryption was successful and matches the original content.");
        } else {
            System.out.println("Decryption failed or the content does not match.");
        }
    }
}
