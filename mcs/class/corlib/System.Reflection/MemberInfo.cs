//
// System.Reflection.MemberInfo.cs
//
// Author:
//   Miguel de Icaza (miguel@ximian.com)
//
// (C) Ximian, Inc.  http://www.ximian.com
//
// TODO: Mucho left to implement.
//

namespace System.Reflection {

	public abstract class MemberInfo : ICustomAttributeProvider {

		public abstract Type DeclaringType {
			get;
		}

		public abstract MemberTypes MemberType {
			get;
		}

		public abstract string Name {
			get;
		}

		public abstract Type ReflectedType {
			get;
		}

		public abstract bool IsDefined (Type attribute_type, bool inherit);

		public abstract object [] GetCustomAttributes (bool inherit);

		public abstract object [] GetCustomAttributes (Type attribute_type, bool inherit);
	}
}
