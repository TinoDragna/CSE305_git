public abstract class Document {
    protected String extension;
    protected String encryption;

    public abstract Document setFileExtension(String extension);
    public abstract Document setEncryption(String encryption);
    public abstract Document buildDoc();
}  