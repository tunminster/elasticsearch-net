﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Nest
{
	public enum HighlighterType
	{
		[EnumMember(Value = "plain")]
		Plain,
		[EnumMember(Value = "postings")]
		Postings,
		[EnumMember(Value = "fvh")]
		Fvh
	}
}
