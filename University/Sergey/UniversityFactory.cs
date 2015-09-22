namespace University.Sergey
{
    class UniversityFactory : IUniversityFactory
    {
        public IUniversity CreateUniversity(string title)
        {
            return new Models.University(title);
        }

        public string ProgrammerName
        {
            get { return "Sergey Matvienko"; }
        }
    }
}
