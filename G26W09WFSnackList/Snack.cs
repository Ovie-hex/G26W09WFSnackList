using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace G26W09WFSnackList
{
    public record Snack(
        string Name,
        string Reason,
        string Image
    )
    {
        [Key]
        public int Id { get; init; }

        public override string ToString() => $"[{Name}] {Reason}";
    }
}
