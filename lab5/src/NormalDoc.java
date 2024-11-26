public class NormalDoc extends Document {

    @Override
    public Document setFileExtension(String extension) {
        this.extension = extension; // ".txt" extension
        return this;
    }

    @Override
    public Document setEncryption(String encryption) {
        this.encryption = "None";
        return this;
    }

    @Override
    public Document buildDoc() {
        System.out.println("Normal document built with extension: " + this.extension);
        return this;
    }
}