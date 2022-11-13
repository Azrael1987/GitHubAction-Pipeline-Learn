namespace TestProject_PipeLine_Learn
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int sum = 2+3;

            Assert.Equal(5, sum);
            Assert.NotEqual(9, sum);
            Assert.True(true);
            Assert.False(false);
        }
    }
}