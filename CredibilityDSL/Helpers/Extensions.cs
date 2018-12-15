using System;
using System.Linq;

namespace CredibilityDSL
{
    public static class Extensions
    {
        public static ClientQuenstionForm GetInputData(this ClientQuenstionForm form)
        {
            foreach (var property in form.GetType().GetProperties())
            {
                var a = property.GetCustomAttributes(typeof (InputDataAttribute), true)
                    .Cast<InputDataAttribute>().FirstOrDefault();

                if (a == null) continue;

                Console.WriteLine(a.Question + ":");
                var t = Console.ReadLine();

                var r = Convert.ChangeType(t, property.PropertyType == typeof(Money) ? typeof(int) : property.PropertyType);
                if (property.PropertyType == typeof(Money))
                    r = new Money((int) r);
                property.SetValue(form, r, null);
            }

            return form;
        }
    }
}