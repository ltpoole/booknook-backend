import axios from "axios";
import React, { useState, useEffect } from "react";
import { Link, useParams } from "react-router-dom";
import Book from "./Book";
import ReviewList from "./ReviewList";
import ReviewForm from "./ReviewForm";
import useAuth from "../../hooks/useAuth";

const BookDetailsPage = () => {
  const { bookId } = useParams();
  const [book, setBook] = useState(null);
  const [bookDetails, setbookDetails] = useState([]);
  const [user, token] = useAuth();

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
    getBookDetails();
  }, [bookId]);

  const getBookDetails = async () => {
    try {
      let response = await axios.get(
        `https://localhost:5001/api/bookdetails/${bookId}`,
        { headers: { Authorization: "Bearer " + token } }
      );
      setbookDetails(response.data);
    } catch (error) {
      console.log(error);
    }
  };

  return (
    <div>
      {book && (
        <div>
          <Book book={book} />
          {bookDetails.reviews.length != 0 && (
            <ReviewList reviews={bookDetails.reviews} />
          )}
          <ReviewForm bookId={bookId} />
        </div>
      )}
    </div>
  );
};

export default BookDetailsPage;
