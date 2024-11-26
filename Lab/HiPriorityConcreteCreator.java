public class HiPriorityConcreteCreator extends RequestCreator{

    @Override
    public RequestProduct createRequest() {
        return new HighPriorityConcrete();
    }
    
}
