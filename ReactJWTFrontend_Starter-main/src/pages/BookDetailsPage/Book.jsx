import React from "react";

const Book = ({ book }) => {
  return (
    <div>
      <h2>{book.volumeInfo.title}</h2>
      <h3>{book.volumeInfo.authors}</h3>
      <p>{book.volumeInfo.description}</p>
    </div>
  );
};

export default Book;
