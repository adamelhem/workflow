namespace TestProject
{
    public class Tests
    {
        private string _inputStartRootNode;
        private string _inputDestNode;
        private string _inputDestNodeAdam;
        private double _expectedDistance;
        private double _expectedDistanceAdam;
        List<string> _graphAdam;

        [SetUp]
        public void Setup()
        {
            _inputStartRootNode = "A";
            _inputDestNode = "Z";
            _inputDestNodeAdam = "F";
            _expectedDistance = 52;
            _expectedDistanceAdam = 8;
            // This list hold the nodes connections information
            _graphAdam = new List<string>()
        {
            "A,B,1",
            "A,C,2",
            "B,D,3",
            "C,E,4",
            "C,D,1",
            "D,F,5",
            "E,F,6"
        };
        }

        [Test]
        public void Test1()
        {
            var result = new Dijkstra().PrintShortestPath(_inputStartRootNode, _inputDestNode);
            Assert.AreEqual(_expectedDistance, result);

            var dijkstraAdam = new DijkstraAdam(_graphAdam, _inputStartRootNode);
            var resultAdam = dijkstraAdam.GetShortestPathDistance(_inputDestNodeAdam);
            Assert.AreEqual(_expectedDistanceAdam, resultAdam);
        }
    }
}