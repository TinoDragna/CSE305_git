import java.io.FileWriter;
import java.io.IOException;

public class NormalDocument extends Document {

    @Override
    public Document buildDocument() {
        this.setExtension("txt");
        this.setEncryption("None");
        return this;
    }

    public void saveFile(String fileName, String content) { 
        try { 
            FileWriter writer = new FileWriter(fileName + "." + this.extension); 
            writer.write(content); writer.close(); 
            System.out.println("Normal document saved successfully."); 
        } catch (IOException e) { 
            System.out.println("An error occurred while saving the normal document."); 
            e.printStackTrace(); 
        }
    }
}
