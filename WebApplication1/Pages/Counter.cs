using Microsoft.AspNetCore.Components;

namespace WebApplication1.Pages
{
    public partial class Counter:ComponentBase
    {
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }
    }
}