namespace Inheritance
{
    internal class Team : Sponsor
    {
        private readonly string _teamName;

        internal Team(string teamName)
        {
            _teamName = teamName;
        }

        internal string PrintInfo()
        {
            return owner + " is owner of the team " + _teamName.ToUpper();
        }
    }
}
