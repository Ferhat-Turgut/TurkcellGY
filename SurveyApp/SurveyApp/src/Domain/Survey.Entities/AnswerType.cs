using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Entities
{
    public enum AnswerType
    {
        SingleLineText,  // Tek satırlık düz metin
        MultiLineText,   // Çok satırlı düz metin
        RatingScale,     // Değerlendirme (1-10)
        MultipleChoice   // Çoktan seçmeli (tek seçim)
    }
}
