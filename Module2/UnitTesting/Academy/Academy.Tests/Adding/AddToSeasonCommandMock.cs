using Academy.Commands.Adding;
using Academy.Core.Contracts;

namespace Academy.Tests.Adding
{
    internal class AddToSeasonCommandMock:AddStudentToSeasonCommand
    {
        private IAcademyFactory object1;
        private IEngine object2;

        public AddToSeasonCommandMock(IAcademyFactory object1, IEngine object2)
            :base(object1,object2)
        {
            this.object1 = object1;
            this.object2 = object2;
        }

        public IAcademyFactory AcademyFactory
        {
            get
            {
                return this.object1;
            }
        }
        public IEngine Engine
        {
            get
            {
                return this.object2;
            }
        }

    }
}