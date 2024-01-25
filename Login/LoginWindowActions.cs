using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookshopWpf.Login;

public class LoginWindowActions : ILoginWindowActions
{
    public Action OkAction { get; set; }
    public Action CancelAction { get; set; }
}
