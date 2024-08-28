
using ProtoBuf;

namespace MyApi.Contract;

[ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
public class FeatureList
{
    public FeatureList()
    {
        features = [];
    }

    public FeatureList(List<int> features) 
    { 
        this.features = features;
    }

    public List<int> features { get; set; }

    public MessageType MessageType { get; init; }
}
