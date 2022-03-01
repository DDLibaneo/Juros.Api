namespace Juros.Api.Integration.Tests
{
    public class CommonFixture
    {
        public JurosApiFixture JurosApiFixture { get; set; }

        public CommonFixture()
        {
            JurosApiFixture = new JurosApiFixture();
        }
    }
}
