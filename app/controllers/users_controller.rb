class UsersController < ApplicationController
  def index
    render json: User.all
  end

  def show
    @user = User.find(params[:id])
    render json: @user.records 
  end

  def get_current_user 
    render json: user_signed_in?
    # render json: {"what": "who"}
  end
end

# {username: "newTest", password: "password", email: "new@test.cool"}

    # axios.post('/users', {
    #   user: {
    #     email: "tbisson11@gmail.com",
    #     password: "password",
    #     password_confirmation: "password"
    #   }
    # })

    # $.ajax({
    #     method: 'post',
    #     url: `/users`,
    #     data: {
    #     email: "tbisson11@gmail.com",
    #     password: "password",
    #     password_confirmation: "password"
    #   }
    # });