//http://www.planetgeek.ch/2012/03/22/how-to-suppress-exceptions-with-fluent-assertions/
//Used at the end of in Fluent Assertion to ignore the exception. 
//More extension can be create after this.

public static class CustomAssertionExtensions
{
    public static bool IgnoreAnyExceptions<TException>(this Action action)
        where TException : Exception
    {
        try
        {
            action();
            return true;
        }
        catch(TException e)
        {
            return false;
            Debug.WriteLine(e.Message);
        }
    }
}

