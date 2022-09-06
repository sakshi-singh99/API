using Microsoft.EntityFrameworkCore;

namespace WebApiApplication.viewModel
{
    [Keyless]
    public class NineGridDetails
    {
        public string Description { set; get; }
        public int Choice { set; get; }
    }
}
