using System;
using HelloWorld.ViewModel;
using NUnit.Framework;

namespace UnitTestProject
{
    [TestFixture]
    public class ViewModelTest
    {
        [Test]
        public void ViewModel_TestGreeting()
        {
            MainViewModel vm = new MainViewModel();

            Assert.IsNull(vm.Greeting);
            Assert.NotNull(vm.GreetCommand);

            vm.GreetCommand.Execute(null);

            Assert.NotNull(vm.Greeting);
            Assert.IsNotEmpty(vm.Greeting);
            Assert.AreEqual("Hello Devs", vm.Greeting);
            Assert.NotNull(vm.GreetCommand);
        }
    }
}
