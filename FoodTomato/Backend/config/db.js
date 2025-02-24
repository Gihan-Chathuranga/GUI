import mongoose  from "mongoose";

export const connectDB = async () =>{
    await mongoose.connect('mongodb+srv://GihanChathurangaFood:AGHC20024567abc@cluster0.winp8.mongodb.net/food-tomato').then(()=>console.log("DB Connected"));
}