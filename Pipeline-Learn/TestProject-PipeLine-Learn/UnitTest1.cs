namespace TestProject_PipeLine_Learn
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int sum = 2+3;

            Assert.True(true);
            Assert.False(false);
            Assert.Equal(5, sum);
        }
    }
}