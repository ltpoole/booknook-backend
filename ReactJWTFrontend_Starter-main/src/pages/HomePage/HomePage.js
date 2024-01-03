import React from "react";
import { useEffect, useState } from "react";
import useAuth from "../../hooks/useAuth";

import axios from "axios";

const HomePage = () => {
  // The "user" value from this Hook contains user information (id, userName, email) from the decoded token
  // The "token" value is the JWT token sent from the backend that you will send back in the header of any request requiring authentication
  const [user, token] = useAuth();
  const [favorites, setFavorites] = useState([]);

  useEffect(() => {
    fetchFavorites();
  }, [token]);

  const fetchFavorites = async () => {
    try {
      let response = await axios.get(
        "https://localhost:5001/api/Favorites/myFavorites",
        {
          headers: {
            Authorization: "Bearer " + token,
          },
        }
      );
      setFavorites(response.data);
    } catch (error) {
      console.log(error.response.data);
    }
  };

  return (
    <div className="container">
      {console.log(user)}
      <h1>{user.userName}'s Bookshelf</h1>
      {favorites &&
        favorites.map((favorite) => (
          <p key={favorite.bookid}>
            {favorite.title} {favorite.thumbnail}
          </p>
        ))}
    </div>
  );
};

export default HomePage;
