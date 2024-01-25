using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookshopWpf.Login;

    public interface ILoginWindowActions
    {
        Action CancelAction { get; set; }
        Action OkAction { get; set; }
    }
