import React, { useState } from "react";
import axios from "axios";

const ReviewForm = ({ bookId }) => {
  const [text, setText] = useState("");
  const [rating, setRating] = useState(0);

  const handleTextChange = (e) => {
    setText(e.target.value);
  };

  const handleRatingChange = (newRating) => {
    setRating(newRating);
  };

  const handleReviewSubmit = async (e) => {
    e.preventDefault();

    try {
      await axios.post(`https://localhost:5001/api/${bookId}reviews`, {
        text,
        rating,
      });
    } catch (error) {
      console.log("Error submitting review: ", error);
    }
  };
  return (
    <div>
      <h3>Add a Review</h3>
      <form onSubmit={handleReviewSubmit}>
        <textarea
          value={text}
          onChange={handleTextChange}
          placeholder="Write your review..."
          rows="4"
        ></textarea>
        <label>
          Rating:
          <select
            value={rating}
            onChange={(e) => handleRatingChange(parseInt(e.target.value))}
          >
            <option value="0">Rate (1-5)</option>
            <option value="1">1</option>
            <option value="2">2</option>
            <option value="3">3</option>
            <option value="4">4</option>
            <option value="5">5</option>
          </select>
        </label>
        <button type="submit">Submit Review</button>
      </form>
    </div>
  );
};

export default ReviewForm;
