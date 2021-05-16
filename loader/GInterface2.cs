using System;
using System.Reflection;

namespace loader
{
	public interface GInterface2
	{
		MethodBase AsMethod(int token);

		FieldInfo AsField(int token);

		Type AsType(int token);

		string AsString(int token);

		MemberInfo AsMember(int token);

		byte[] AsSignature(int token);
	}
}
