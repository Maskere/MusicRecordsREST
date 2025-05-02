using Microsoft.VisualStudio.TestTools.UnitTesting;
using DRMusic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRMusic.Tests
{
    [TestClass()]
    public class MusicRecordTests
    {

        [TestMethod]
        public void EmptyConstructor_ShouldInitializePropertiesToDefaultValues()
        {
            // Arrange
            var musicRecord = new MusicRecordModel();

            // Act & Assert
            Assert.IsNull(musicRecord.Title);
            Assert.IsNull(musicRecord.Artist);
            Assert.AreEqual(0, musicRecord.Duration);
            Assert.AreEqual(0, musicRecord.Publication_year);
        }

        [TestMethod]
        public void ToString_ShouldReturnFormattedString()
        {
            // Arrange
            var musicRecord = new MusicRecordModel("Imagine", "John Lennon", 183, 1971);
            var expected = "Title: Imagine, Artist: John Lennon, Duration: 183, Publication Year: 1971";

            // Act
            var result = musicRecord.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}