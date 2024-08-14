using System;
using Moq;

namespace SamplePrismApp.Testing.ViewModels
{
	public class MainPageViewModelTest
	{
		public MainPageViewModelTest()
		{
		}

        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, 2 + 2);
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, 2 + 2);
        }
    }
}

