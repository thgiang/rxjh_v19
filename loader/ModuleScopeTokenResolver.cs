using System;
using System.Reflection;

namespace loader
{
	public class ModuleScopeTokenResolver : GInterface2
	{
		private Module m_module;

		private MethodBase m_enclosingMethod;

		private Type[] m_methodContext;

		private Type[] m_typeContext;

		public ModuleScopeTokenResolver(MethodBase method)
		{
			m_enclosingMethod = method;
			m_module = method.Module;
			m_methodContext = ((method is ConstructorInfo) ? null : method.GetGenericArguments());
			m_typeContext = ((method.DeclaringType == null) ? null : method.DeclaringType.GetGenericArguments());
		}

		public MethodBase AsMethod(int token)
		{
			return m_module.ResolveMethod(token, m_typeContext, m_methodContext);
		}

		public FieldInfo AsField(int token)
		{
			return m_module.ResolveField(token, m_typeContext, m_methodContext);
		}

		public Type AsType(int token)
		{
			return m_module.ResolveType(token, m_typeContext, m_methodContext);
		}

		public MemberInfo AsMember(int token)
		{
			return m_module.ResolveMember(token, m_typeContext, m_methodContext);
		}

		public string AsString(int token)
		{
			return m_module.ResolveString(token);
		}

		public byte[] AsSignature(int token)
		{
			return m_module.ResolveSignature(token);
		}
	}
}
