using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBook.Core.ValueObjects;

public record MileageRange(long StartMileage, long EndMileage);
