import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

class Contact {
    private final String name;

    public Contact(String name) {
        this.name = name;
    }

    public String getName() {
        return name;
    }
}

class Message {
    private final String content;
    private final String sender; // người gửi
    private final String recipient; // người nhận

    public Message(String content, String sender, String recipient) {
        this.content = content;
        this.sender = sender;
        this.recipient = recipient;
    }
    // Getters for message properties
    public String getContent() {
        return content;
    }
    public String getSender() {
        return sender;
    }

    public String getRecipient() {
        return recipient;
    }
	public void printSummary() {
		System.out.println("Content: " + content);
		System.out.println("Sender: " + sender);
		System.out.println("Recipient: " + recipient);
	}

    //fix Duplication
    private String formatDetails() {
        return String.format(
            "Content Length: %d%nSender Uppercase: %s%nRecipient Lowercase: %s",
            content.length(), sender.toUpperCase(), recipient.toLowerCase());
    }

    public void printDetails() {
        printSummary();
        System.out.println(formatDetails());
    }
}

class MessagingService {
    private final Map<String, List<Message>> inbox;

    public MessagingService() {
        this.inbox = new HashMap<>();
    }
    public void sendMessage(String content, String sender, String recipient) {
        Message message = new Message(content, sender, recipient);
        inbox.computeIfAbsent(message.getRecipient(), k -> new ArrayList<>()).add(message);
    }

    public List<Message> getMessagesForRecipient(String recipient) {
        return inbox.getOrDefault(recipient, new ArrayList<>());
    }   
    public void printAllMessages() {
        for (String recipient : inbox.keySet()) {
            List<Message> messages = inbox.get(recipient);
            for (Message message : messages) {
                message.printSummary();
            }
        }
    }
}

public class CommunicationManager_V1 {
    public static void main(String[] args) {
        MessagingService messagingService = new MessagingService();

        // sending messages
        messagingService.sendMessage("Hello, tenant!", "Property Manager", "Tenant A");
        messagingService.sendMessage("Important notice: Rent due next week.", "Property Owner", "Tenant A");
        messagingService.sendMessage("Maintenance request received.", "Tenant A", "Property Manager");

        // retrieving messages for a recipient - Lấy danh sách tin nhắn của một người nhận
        List<Message> tenantAMessages = messagingService.getMessagesForRecipient("Tenant A");
        for (Message message : tenantAMessages) {
            System.out.println("From: " + message.getSender() + ", Content: " + message.getContent());
        }

        // Calling the new method - Kiểm tra chi tiết tin nhắn
        Message exampleMessage = new Message("Test", "Sender", "Recipient");
        exampleMessage.printDetails();

        messagingService.printAllMessages();
    }
}





