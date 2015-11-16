namespace NumberOfTimesService
{
    using System.ServiceModel;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface INumberOfTimesService
    {
        [OperationContract]
        int GetCounts(string text, string strToFind);

    }

}
