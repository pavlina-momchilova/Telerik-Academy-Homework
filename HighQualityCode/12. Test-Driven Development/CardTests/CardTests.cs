
namespace CardTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Poker;

    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void ToStringMustReturnAceHeart()
        {
            Card aceHeart = new Card(CardFace.Ace, CardSuit.Hearts);
            Assert.AreEqual("A♥", aceHeart.ToString(), "Card ToString method sholud return card Ace Heart as string A♥ !");
        }

        [TestMethod]
        public void ToStringMustReturnKingDiamond()
        {
            Card kingDiamond = new Card(CardFace.King, CardSuit.Diamonds);
            Assert.AreEqual("K♦", kingDiamond.ToString(), "Card ToString method sholud return card King diamond as string K♦!");
        } 
 
        [TestMethod]
        public void ToStringMustReturnQueenSpade()
        {
            Card queenSpade = new Card(CardFace.Queen, CardSuit.Spades);
            Assert.AreEqual("Q♣", queenSpade.ToString(), "Card ToString method sholud return card queen spade as string Q♣!");
        }

        [TestMethod]
        public void ToStringMustReturnJackClub()
        {
            Card jackClub = new Card(CardFace.Jack, CardSuit.Clubs);
            Assert.AreEqual("J♠", jackClub.ToString(), "Card ToString method sholud return card jack club as string J♠!");
        }

        [TestMethod]
        public void ToStringMustReturnTwoClub()
        {
            Card twoClub = new Card(CardFace.Two, CardSuit.Clubs);
            Assert.AreEqual("2♠", twoClub.ToString(), "Card ToString method sholud return card two club as string 2♠!");
        }
    }
}
