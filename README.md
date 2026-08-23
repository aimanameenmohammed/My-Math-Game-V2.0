<div align="center">

# 🧠 Math Genius Challenge

[![C#](https://img.shields.io/badge/Language-C%23-blue.svg?style=for-the-badge&logo=c-sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Framework](https://img.shields.io/badge/Framework-.NET%20Framework-purple.svg?style=for-the-badge&logo=dotnet)](https://dotnet.microsoft.com/)
[![UI Focus](https://img.shields.io/badge/UI%2FUX-Custom%20GDI%2B-orange.svg?style=for-the-badge)](https://github.com/)
[![License](https://img.shields.io/badge/License-MIT-green.svg?style=for-the-badge)](LICENSE.txt)

<p align="center">
  <b>لعبة تحدي الرياضيات العصرية والذكية المخصصة لتعزيز المهارات الحسابية بأسلوب ممتع وتصميم تفاعلي جذاب يناسب جميع الأعمار.</b>
</p>

[📌 نظرة عامة](#-نظرة-عامة) •
[✨ المميزات الرئيسية](#-المميزات-الرئيسية) •
[📸 لقطات من الشاشة](#-لقطات-من-الشاشة) •
[🛠️ المعمارية والهندسة](#️-المعمارية-والهندسة) •
[🚀 طريقة التشغيل](#-طريقة-التشغيل) •
[📞 التواصل والتطوير](#-التواصل-والتطوير)

---

</div>

## 📌 نظرة عامة

مشروع **Math Genius Challenge** هو إعادة تطوير شاملة وتطبيق عصري للعبة الرياضيات السابقة التي بُنيت بـ ++C. تم نقل اللعبة إلى بيئة `#C` و `WinForms` للارتقاء بتجربة المستخدم (UX)، حيث تجمع بين البساطة وسهولة التحكم والأداء السلس لتقديم تجربة تعليمية وتنافسية ممتازة للأطفال والكبار على حد سواء.

---

## ✨ المميزات الرئيسية

* 🎯 **نظام اختيار دقيق (Single-Selection Logic):** استخدام RadioButtons مخصصة بنمط Buttons لضمان اختيار إجابة واحدة فقط بمرونة وبدون أخطاء.
* ⏱️ **مؤقت التحدي (Per-Question Timer):** إضافة عامل الوقت بالثواني لكل سؤال لزيادة الحماس وقياس سرعة البديهة.
* 🎨 **تصميم عصري ورسومات مخصصة (Custom Round Controls):** قص حواف عناصر الواجهة بدقة (Rounded Corners) لإعطاء طابع عصري وأنثق.
* 📊 **لوحة نتائج مدمجة (In-App Result Panel):** عرض ملخص النتيجة النهائية وسجل الأداء داخل نفس الواجهة دون الحاجة لفتح نوافذ جديدة.
* 🎵 **مؤثرات صوتية تفاعلية (Audio Integration):** إضافة موسيقى وأصوات تفاعلية لإضفاء بيئة حماسية أثناء اللعب.
* ⚙️ **تخصيص مستويات صعوبة متنوعة:** إمكانية التحكم بنوع العمليات الحسابية (جمع، طرح، ضرب، قسمة، أو مشكل) مع تعديل مستوى الصعوبة وعدد الأسئلة.

---

## 📸 لقطات من الشاشة

<div align="center">

> 💡 **ضع صورة واجهة اللعبة هنا:** قم بسحب وإسقاط صورة الواجهة الرئيسية داخل هذا المربع في GitHub.

| الواجهة الرئيسية للعبة |
| :--
<!-- Failed to upload "Annotation 2026-08-23 103930.png" -->-: |
| <!-- Drag and drop your main UI screenshot here --> |

</div>

---

## 🛠️ المعمارية والهندسة (Clean Code & Architecture)

تم بناء المشروع مع التركيز العالي على **نظافة الكود (Clean Code)** وتطوير معمارية مرنة قابلة للتوسع:

* 🧩 **Unified Event Handling:** تجميع جميع أزرار خيارات الإجابة تحت حدث واحد (`Event Handler`) تقليلاً للتكرار وتحقيقاً لمبدأ DRY (Don't Repeat Yourself).
* 📐 **Custom Dynamic UI Class (`ClsUlcs`):** بناء كلاس مخصص يحتوي على Functions استقبالية هجينة للتعامل مع مختلف أنواع الـ Controls (`RadioButton`, `Button`, `Panel`) للتحكم في الأشكال، الحواف، والألوان بمرونة كاملة.

---

## 🚀 طريقة التشغيل (Installation & Setup)

### المتطلبات الأساسية
* مثبت **Visual Studio 2019** أو أحدث.
* بيئة **.NET Framework 4.8** أو أعلى.

### خطوات التشغيل
1. **استنسخ المستودع (Clone):**
   ```bash
   git clone [https://github.com/aimanameenmohammed/MyMathGame.git](https://github.com/aimanameenmohammed/MyMathGame.git)
