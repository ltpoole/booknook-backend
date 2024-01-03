import axios from "axios";
import React, { useState, useEffect } from "react";
import { Link, useParams } from "react-router-dom";
import Book from "./Book";
import ReviewList from "./ReviewList";
import ReviewForm from "./ReviewForm";

const BookDetailsPage = () => {
  const { bookId } = useParams();
  const [book, setBook] = useState(null);
  const [reviews, setReviews] = useState([]);
  console.log(book);

  useEffect(() => {
    const fetchBook = async () => {
      try {
        let response = await axios.get(
          `https://www.googleapis.com/books/v1/volumes/${bookId}`
        );
        setBook(response.data);
      } catch (error) {
        console.log(error);
      }
    };
    fetchBook();
  }, [bookId]);

  return (
    <div>
      {book && (
        <div>
          <Book book={book} />
          <ReviewList reviews={reviews} />
          <ReviewForm bookId={bookId} />
        </div>
      )}
    </div>
  );
};

export default BookDetailsPage;
