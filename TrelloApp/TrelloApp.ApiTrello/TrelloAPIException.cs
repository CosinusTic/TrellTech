using Android.Util;
using Refit;
using Serilog;

namespace TrelloApp.ApiTrello;

public class TrelloAPIException : Exception
{
    public TrelloAPIException(ApiException e)
    {
        
    }
}