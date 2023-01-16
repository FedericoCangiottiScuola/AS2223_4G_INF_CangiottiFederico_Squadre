using Library;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddPlayers()
        {
            Team team = new Team("Team 1");
            Player playerRosa = new Player("nome", "cognome", Player.ERole.Rosa);
            Player playerRiserva = new Player("nome", "cognome", Player.ERole.Riserva);

            Assert.That(team.AddPlayer(playerRosa), Is.EqualTo(true));
            Assert.That(team.AddPlayer(playerRosa), Is.EqualTo(true));
            Assert.That(team.AddPlayer(playerRosa), Is.EqualTo(true));
            Assert.That(team.AddPlayer(playerRosa), Is.EqualTo(true));
            Assert.That(team.AddPlayer(playerRosa), Is.EqualTo(true));
            Assert.That(team.AddPlayer(playerRosa), Is.EqualTo(true));
            Assert.That(team.AddPlayer(playerRosa), Is.EqualTo(true));
            Assert.That(team.AddPlayer(playerRosa), Is.EqualTo(true));
            Assert.That(team.AddPlayer(playerRosa), Is.EqualTo(true));
            Assert.That(team.AddPlayer(playerRosa), Is.EqualTo(true));
            Assert.That(team.AddPlayer(playerRosa), Is.EqualTo(true));
            Assert.That(team.AddPlayer(playerRosa), Is.EqualTo(false));

            Assert.That(team.AddPlayer(playerRiserva), Is.EqualTo(true));
            Assert.That(team.AddPlayer(playerRiserva), Is.EqualTo(true));
            Assert.That(team.AddPlayer(playerRiserva), Is.EqualTo(true));
            Assert.That(team.AddPlayer(playerRiserva), Is.EqualTo(false));
        }

        [Test]
        public void AddCaptain()
        {
            Team team = new Team("Team 1");
            Player capitanoGiusto = new Player("nome", "cognome", Player.ERole.Rosa);
            Player capitanoSbagliato = new Player("nome", "cognome", Player.ERole.Riserva);

            Assert.That(team.AddCaptain(capitanoGiusto), Is.EqualTo(true));
            Assert.That(team.AddCaptain(capitanoGiusto), Is.EqualTo(true));

            Assert.That(team.AddCaptain(capitanoSbagliato), Is.EqualTo(false));
            Assert.That(team.AddCaptain(capitanoGiusto), Is.EqualTo(true));
        }
    }
}