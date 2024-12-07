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

        [Fact]
        public void Subtract_4_from_7_Results_3()
        {
            var calc = new Calculator();
            var result = calc.Subtract(7, 4);
            Assert.Equal(3, result);
        }
    }
}