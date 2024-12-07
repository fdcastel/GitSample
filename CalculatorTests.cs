namespace GitSample
{
    public class CalculatorTests
    {
        [Fact]
        public void Sum_3_and_4_Results_7()
        {
            var calc = new Calculator();

            var result = calc.Add(3, 4);

            Assert.Equal(7, result);
        }
    }
}