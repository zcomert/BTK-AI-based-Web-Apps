import * as Yup from 'yup';

const BookValidationSchema = Yup.object().shape({
    title: Yup.string().required('Kitap adı boş bırakılamaz'),

    price: Yup
        .number()
        .typeError('Lütfen geçerli fiyat giriniz.')
        .positive('Sifirdan kucuk olamaz')
        .required('Fiyat bilgisi boş bırakılamaz')
        .min(10, 'Fiyatı 10 küçük olamaz.')
        .max(1000, 'Fiyat 1000 den büyük olamaz'),

    author: Yup.string().required('Yazar bilgisi boş bırakılamaz'),
});

export default BookValidationSchema;
